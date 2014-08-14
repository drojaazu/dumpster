using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.IO;
using dumplib;

namespace Dumpster2
{
    internal static class LibLoad
    {
        internal static void InitLibs()
        {

            // load dumplib for reflection
            Assembly dumplib3 = Assembly.ReflectionOnlyLoadFrom("DumpLib.dll");

            Assembly dumplibasm  = Assembly.LoadFile(Path.Combine(Program.WorkDir, "DumpLib.dll"));
            // get a list of all the external assemblies and load them
            AssemblyName[] dumplib_refs = dumplibasm.GetReferencedAssemblies();
            for (int h = 0; h < dumplib_refs.Length; h++)
                Assembly.ReflectionOnlyLoad(dumplib_refs[h].FullName);

            var filter = new TypeFilter(InterfaceFilter);
            
            var j = dumplibasm.GetTypes();
            Type[] ifaces = null;
            foreach (var type in j)
            {
                ifaces = type.FindInterfaces(filter, "dumplib.Gfx.IColorConverter");
                if (ifaces.Length > 0)
                {
                    dumplib.Gfx.IColorConverter newinstance = (dumplib.Gfx.IColorConverter)Activator.CreateInstance(type);
                    Program.ColorConverters.Add(newinstance.ID, newinstance);
                }

                ifaces = type.FindInterfaces(filter, "dumplib.Gfx.ITileConverter");
                if (ifaces.Length > 0)
                {
                    dumplib.Gfx.ITileConverter newinstance = (dumplib.Gfx.ITileConverter)Activator.CreateInstance(type);
                    Program.TileConverters.Add(newinstance.ID, newinstance);
                }

                ifaces = type.FindInterfaces(filter, "dumplib.Gfx.IPaletteConverter");
                if (ifaces.Length > 0)
                {
                    dumplib.Gfx.IPaletteConverter newinstance = (dumplib.Gfx.IPaletteConverter)Activator.CreateInstance(type);
                    Program.PaletteConverters.Add(newinstance.ID, newinstance);
                }

                //if (type.BaseType != null && type.BaseType.FullName == "dumplib.Image.MediaImage") Program.MediaImages.Add((dumplib.Image.MediaImage)Activator.CreateInstance(type));
            }
            Console.WriteLine(ifaces.ToString());

            // load teh same from other DLLs

        }

        internal static bool InterfaceFilter(Type typeObj, Object criteriaObj)
        {
            string g = typeObj.ToString();
            return g == criteriaObj.ToString();
        }
    }
}
