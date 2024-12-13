using System;

class HomeWork4{
    public static int[] Merge(int[] a, int[] b){
        int[] res = new int[a.Length + b.Length];
        for(int i = 0; i < a.Length; i++){
            res[i] = a[i];
        }
        for(int i = 0; i < b.Length;i++){
            res[a.Length + i] = b[i];
        }
        return res;
    }

    public static int[] Rotat(int[] a, int i){
        int[] res = new int[a.Length];
        for(int n = 0; n < a.Length; n++){
            if(n + i < a.Length){
                res[n + i] = a[n];
            }
            else{
                res[n + i - a.Length] = a[n];
            }
        }
        return res;
    }

}