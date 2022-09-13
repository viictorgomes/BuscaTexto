using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTexto {
    class ForcaBruta {
        public static int forcaBruta(int index, String p, String t) {
            int i, j, aux;
            int m = p.Length; //tamanho da palavra
            int n = t.Length; //tamanho do texto

            for (i = index; i < n; i++) {
                aux = i;
                for (j = 0; j < m && aux < n; j++) {
                    if (t[aux] != p[j] && p[j] != '?')
                        break;
                    aux++;
                }
                if (j == m)
                    return i;
            }
            return -1;
        }
    }
}
