using System.Collections.Generic;
using UnityEngine;

public sealed class Av1 : MonoBehaviour
{
    [System.Serializable]
    public class Entry
    {
        public string key;
        public int value;
    }

    public List<Entry> entries = new List<Entry>();

    private void Reset()
    {
        entries.Add(new Entry { key = "ola", value = 47 });
        entries.Add(new Entry { key = "coeee", value = 43 });
        entries.Add(new Entry { key = "rapaziaada", value = 4 });
    }
}
