using System;
using System.Linq;

int[] RArr(int min, int max, int length, Random r)
{
    if (min > max++) throw new ArgumentException("");
    if (length < 1) throw new ArgumentException("");

    var res = new int[length];
    for (int i = 0; i < length) res[i] = r.Next(min, max);
    return res;
}

int[] Sort(int[] arr) => arr.OrderBy(x => x).ToArray();

Random R = new Random(DateTime.Now.Millisecond);
int N = R.Next(1, 100001);
int[] arr = Sort(RArr(-1000_000_000, 1000_000_000, N, R));

int l = R.Next(0, arr.Length);
int r = R.Next(l, arr.Length);

int binsearch(int[] a, int l, int r, int x)
{
    if (l < 0 || l > r || x < a[l] || x > a[l]) return -1;

}