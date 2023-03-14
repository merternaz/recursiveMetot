using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] sıra={3,2,5,6};

          Console.WriteLine(sıra.SeriTopla());
          Console.WriteLine(sıra.Sırala());
          Console.WriteLine(sıra.MinMax());
          sıra.ForEachPrint();
          Fonksyonlar ff=new();
          Console.WriteLine(ff.ustel(3,4));
        }
    }

    public class Fonksyonlar
    {
         public int ustel(int n,int val){

            int a=1;
            int sonuc=1;
            if(n<1){
                sonuc=sonuc*1;
            }else{
                sonuc=val*ustel(n-1,val);
            }

            return sonuc;
        }
    }


    public static class Extentsions{

        public static int SeriTopla(this int[] dizi){
            int sum=0;
            foreach (var item in dizi)
            {
                sum+=item;
            }

            return sum;
        }

        public static int[] Sırala(this int[] dizi){
            Array.Sort(dizi);
            return dizi;//.ToArray<int>().Order();
        }

        public static int[] MinMax(this int[] dizi){
            int maxVal=dizi.Max();
            int minVal=dizi.Min();
            int[] minMaxVal=new int[2];
            minMaxVal[0]=minVal;
            minMaxVal[1]=maxVal;
            return minMaxVal;//.ToArray<int>().Order();
        }

        public static void ForEachPrint(this int[] dizi){

            foreach(var i in dizi){
                Console.WriteLine(i);
            }
        }

       


    }
}
