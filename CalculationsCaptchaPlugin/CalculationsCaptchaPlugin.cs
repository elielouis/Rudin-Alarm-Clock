using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaptchaPluginsFramework;

namespace CalculationsCaptchaPlugin
{
    public class CalculationsCaptchaPlugin : CaptchaPluginBase
    {
        public CalculationsCaptchaPlugin() : base()
        { }

        public override CaptchaChallenge GetChallenge()
        {
            Random r = new Random();
            int a, b;
            string question, answer;
            switch (_difficulty)
            {
                case 1:
                    {
                        a = r.Next(1, 10);
                        b = r.Next(1, 10);
                        question = String.Format("{0} x {1}", a, b);
                        answer = String.Format("{0}", a * b);
                        break;
                    }
                case 2:
                    {
                        a = r.Next(1, 1000);
                        b = r.Next(1, 1000);
                        question = String.Format("{0} - {1}", a, b);
                        answer = String.Format("{0}", a - b);
                        break;
                    }
                case 3:
                    {
                        a = r.Next(10, 100);
                        b = r.Next(10, 100);
                        question = String.Format("{0} x {1}", a, b);
                        answer = String.Format("{0}", a * b);
                        break;
                    }
                default:
                    {
                        a = r.Next(100, 1000);
                        b = r.Next(100, 1000);
                        question = String.Format("{0} x {1}", a, b);
                        answer = String.Format("{0}", a * b);
                        break;
                    }
            }
            
            return new CaptchaChallenge(question, answer);
        }

        public override string GetName()
        {
            return "Calculations";
        }
    }
}
