namespace Algorithm
{
    public class SolutionIntersect
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = [];
            List<int> result = [];

            // nums1 dizisindeki elemanların frekansını say
            foreach (int n in nums1)
            {
                dict[n] = dict.GetValueOrDefault(n, 0) + 1;
            }

            // nums2'deki elemanların kesişim elemanlarını kontrol et
            foreach (int n in nums2)
            {
                if (dict.GetValueOrDefault(n, 0) > 0)
                {
                    result.Add(n);
                    dict[n]--;
                }
            }

            return result.ToArray();
        }
    }
}
