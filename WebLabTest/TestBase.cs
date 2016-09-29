using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLabTest
{
    public abstract class TestBase
    {

        protected bool ShowException { get; set; }

        protected TestBase()
        {
            Test();
        }

        protected abstract void Test();

        protected void Write(string actionDescription, Action action)
        {
            try
            {

                action();
                Console.ForegroundColor = ConsoleColor.Green;

            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;

                if (ShowException)
                {
                    Console.WriteLine(ex);
                }

            }
            finally
            {

                Console.WriteLine(actionDescription);

            }

        }

    }
}
