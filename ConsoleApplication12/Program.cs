using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] g = new int[n,n];
            int[] linia = new int[n];
            int summ = 0;
            for (int i = 0; i < n;i++ )
            {
                linia[i] = 0;
                for (int j = 0; j < n;j++ )
                {
                    g[j, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int ntoch = 0;
            linia[0] = 1;
            while(ntoch<n-1){
                int minn = 9999999;
                int a = 0, b = 0;
                for (int i = 0; i < n;i++ )
                {
                    if (linia[i] == 1)
                    {
                        for (int j = 0; j < n;j++ )
                        {
                            if(linia[j]==0 && g[j,i]!=0){
                                if(minn>g[j,i]){
                                    minn = g[j, i];
                                    a = i;
                                    b = j;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(a + " " + b + " " + g[b,a]);
                linia[b] = 1;
                ntoch += 1;
                summ += g[b, a];
            }
            Console.WriteLine(summ);
        }
    }
}
