using System.Reflection;
using System;
using System.IO;
using CaptchaPluginsFramework;
using System.Collections.Generic;

namespace Rudin.Captcha
{
    public static class CaptchaPluginsUtilities
    {
        public static void ListAllPlugins()
        {
            foreach(var dll in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll"))
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    foreach (var type in asm.GetTypes())
                    {
                        if (type.BaseType == typeof(CaptchaPluginBase))
                        {
                            var captcha = Activator.CreateInstance(type) as CaptchaPluginBase;
                            System.Console.WriteLine(captcha.GetChallenge().ChallengeAnswer);
                        }
                    }
                }
                catch (BadImageFormatException) { }
            }
        }

        public static Dictionary<string, CaptchaPluginBase> LoadPlugins()
        {
            Dictionary<string, CaptchaPluginBase> plugins = new Dictionary<string, CaptchaPluginBase>();
            foreach (var dll in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll"))
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    foreach (var type in asm.GetTypes())
                    {
                        if (type.BaseType == typeof(CaptchaPluginBase))
                        {
                            Console.WriteLine(dll);
                            CaptchaPluginBase captcha = Activator.CreateInstance(type) as CaptchaPluginBase;
                            plugins[captcha.GetName()] = captcha;
                        }
                    }
                }
                catch (BadImageFormatException) {}
            }
            return plugins;
        }
        
        public static void AnalyzeAssembly(string filename)
        {
            var asm = Assembly.LoadFrom(filename);
            foreach (var t in asm.GetTypes())
            {
                Console.WriteLine($"[Type] {t.Name}");
                foreach(var m in t.GetMethods())
                {
                    Console.WriteLine($"\t[Method] {m.Name}");
                }
                foreach(var p in t.GetProperties())
                {
                    Console.WriteLine($"\t[Property] {p.Name}");
                }
                foreach(var f in t.GetFields())
                {
                    Console.WriteLine($"\t[Field] {f.Name}");
                }
            }
        }
    }
}
