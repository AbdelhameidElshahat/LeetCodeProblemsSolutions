public class MyHashSet {
    List<int>[] buckets; 
    int keyRange;

    public MyHashSet() {
        keyRange = 1381;
        buckets = new List<int>[keyRange];
        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }
    }

    private int _hash(int key) {
        return key % keyRange;
    }

    public void Add(int key) {
        int bucketIndex = _hash(key);
        if (!buckets[bucketIndex].Contains(key)) {
            buckets[bucketIndex].Add(key);
        }
    }

    public void Remove(int key) {
        int bucketIndex = _hash(key);
        if (buckets[bucketIndex].Contains(key)) { 
            buckets[bucketIndex].Remove(key); 
        }
    }

    public bool Contains(int key) {
        int bucketIndex = _hash(key);
        return buckets[bucketIndex].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
    


/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */