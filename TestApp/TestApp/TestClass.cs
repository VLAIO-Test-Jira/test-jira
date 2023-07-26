namespace TestApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestClass
    {
        //               ((`\
        //            ___ \\ '--._
        //         .'`   `'    o  )
        //        /    \   '. __.'
        //      _|    /_  \ \_\_
        //     {_\______\-'\__\_\

        public string MyContent { get; set; }
        public bool EatsMeat { get; set; }

        public TestClass(string content)
        {
            MyContent = content;
            EatsMeat = false;
        }
    }
}