using System.Collections;
using System.Collections.Generic;
using System;

public class DictionaryList<T,K>
{
    Dictionary<T, Queue<K>> dic;
    public DictionaryList()
    {
        dic = new Dictionary<T, Queue<K>>();
    }
    public void Add(T indentity,K content)
    {
        Queue<K> q;
        if (dic.ContainsKey(indentity))
        {
            bool hasGottenValue = dic.TryGetValue(indentity, out q);
        }
        else
        {
            q = new Queue<K>();
            dic.Add(indentity, q);
        }
            q.Enqueue(content);
        
    }
    public bool TryGetValue(T indentity, out K content)
    {
        Queue<K> q;
        bool hasGottenValue = dic.TryGetValue(indentity, out q);
        if (!hasGottenValue)
        {
            content = default(K);
            return false;
        }
        else
        {
            if (q.Count<=0)
            {
                content = default(K);
                return false;
            }
            content = q.Dequeue();
            return true;
        }
    }
}
