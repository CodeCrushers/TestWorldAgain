﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorldAgain.Model {
    class Person {

        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

    }
}
