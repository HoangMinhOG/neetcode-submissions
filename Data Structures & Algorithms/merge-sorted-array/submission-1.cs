public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m;
        int j = n;
        int k = m + n - 1;

        while (i > 0 && j > 0)
        {
            if (nums1[i - 1] < nums2[j - 1])
            {
                nums1[k] = nums2[j - 1];
                j--;
            }
            else
            {
                nums1[k] = nums1[i - 1];
                i--;
            }

            k--;
        }

        while (j > 0)
        {
            nums1[k] = nums2[j - 1];
            j--;
            k--;
        }
    }
}