public class MyHashMap {
    List<int[]>[] buckets;
    int keyRange;

    public MyHashMap() {
        keyRange = 997;
        buckets = new List<int[]>[keyRange];
        for (int i = 0; i < keyRange; i++) {
            buckets[i] = new List<int[]>();
        }
    }

    /*
    buckets
  ├── List<int[]> (List 1)
  │    ├── int[] (Array 1)
  │    ├── int[] (Array 2)
  │    └── int[] (Array 3)
  ├── List<int[]> (List 2)
  │    ├── int[] (Array 1)
  │    └── int[] (Array 2)
  └── List<int[]> (List 3)
       ├── int[] (Array 1)
       ├── int[] (Array 2)
       ├── int[] (Array 3)
       └── int[] (Array 4)
    */
    private int _hash(int key) {
        return key % keyRange;
    }

    public void Put(int key, int value) {
        int bucketIndex = _hash(key);
        bool found = false;
        for (int i = 0; i < buckets[bucketIndex].Count; i++) {
            if (buckets[bucketIndex][i][0] == key) {
                buckets[bucketIndex][i][1] = value; 
                found = true;
                break;
            }
        }
        if (!found) {
            buckets[bucketIndex].Add(new int[] { key, value });
        }
    }

    public int Get(int key) {
        int bucketIndex = _hash(key);
        for (int i = 0; i < buckets[bucketIndex].Count; i++) {
            if (buckets[bucketIndex][i][0] == key) {
                return buckets[bucketIndex][i][1]; 
            }
        }
        return -1;
    }

    public void Remove(int key) {
        int bucketIndex = _hash(key);
        for (int i = 0; i < buckets[bucketIndex].Count; i++) {
            if (buckets[bucketIndex][i][0] == key) {
                buckets[bucketIndex].RemoveAt(i);
                break; 
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key, value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */