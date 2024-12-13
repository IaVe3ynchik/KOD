using System;
using System.Runtime.InteropServices;

class HomeWork5{
    public static int Find(int[] a){
        int res = 0;
        int countIndex = 0;
        int countIndex2 = 0;
        for(int i = 0; i < a.Length; i++){
            for(int j = 0;j < a.Length; j++){
                if(a[i] == a[j]){
                    countIndex2++;
                }
            }
            if(countIndex2 > countIndex){
                res = a[i];
            }
        }
        return res;
    }

    public static int[,] Transpon(int[,] a){
        int[,] res = new int[a.GetLength(1), a.GetLength(0)];
        for(int i = 0; i < res.GetLength(0); i++){
            for(int j = 0; j < res.GetLength(1); j++){
                res[i,j] = a[j,i];
            }
        }
        return res;
    }

}