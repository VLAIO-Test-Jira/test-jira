namespace TestApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestClass
    {
        public string MyContent { get; set; }

        public TestClass(string content)
        {
            MyContent = content;
        }
    }
}