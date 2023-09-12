﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoCSV {
    public class Aluno {
        public Aluno() {
        }
        public Aluno(string nome, double n1, double n2, double n3) {
            Nome = nome;
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }
        public string Nome { get; set; }
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }

        public override string ToString() {
            return Nome + " " + N1 + " " + N2 + " " + N3;
        }
    }
}
