public class TimeMap {
    private Dictionary<string, List<(int, string)>> _dict;
    public TimeMap() {
        _dict = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!_dict.ContainsKey(key)) _dict[key] = new List<(int, string)>();
        _dict[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!_dict.ContainsKey(key)) return string.Empty;
        return Search(_dict[key], timestamp);
    }

    private string Search(List<(int, string)> list, int target) {
        var n = list.Count;
        if (n == 0) return string.Empty;
        var min = 0;
        var max = n - 1;

        while (min <= max) {
            var mid = (min + max) / 2;
            var (first, second) = list[mid];
            if (first == target) return second;
            if (first < target) min = mid + 1;
            else max = mid - 1;
        }
        if (max < 0) max = 0; 
        var (t, res) = list[max];        
        return t <= target? res: string.Empty;
    }
}
