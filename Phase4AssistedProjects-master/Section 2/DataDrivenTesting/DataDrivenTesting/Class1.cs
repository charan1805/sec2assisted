﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTesting
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [TestCase(10,20,ExpectedResult =30)]
        [TestCase(100,200,ExpectedResult =300)]
        [TestCase(1000,2000,ExpectedResult =3000)]
        public int DataDriven1(int x,int y)
        {
            var calc = new Calculator();
            return calc.add(x,y);
        }
        public static List<TestCaseData> testCases
        {
            get
            {
                var testCases= new List<TestCaseData>();
                using (var fs = File.OpenRead("C:\\Users\\Keerthana\\OneDrive\\Desktop\\job\\Phase4\\Assisted Projects\\Section 2\\DataDrivenTesting\\DataDrivenTesting\\TextData.txt")) 
                using (var sr = new StreamReader(fs))
                {
                    string line=string.Empty;
                    while(line!=null)
                    {
                        line=sr.ReadLine();
                        if(line!=null)
                        {
                            string[] split = line.Split(new char[] { ',' }, StringSplitOptions.None);
                            int a = Convert.ToInt32(split[0]);
                            int b= Convert.ToInt32(split[1]);
                            int ans = Convert.ToInt32(split[2]);
                            var testCase=new TestCaseData(a,b).Returns(ans);
                            testCases.Add(testCase);
                        }
                    }
                }
                return testCases;
            }
        }
        [Test]
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(100, 200, ExpectedResult = 300)]
        [TestCase(1000, 2000, ExpectedResult = 3000)]
        public int DataDriven2(int x,int y)
        {
            var calc =new Calculator();
            return calc.add(x,y);
        }
    }
}
