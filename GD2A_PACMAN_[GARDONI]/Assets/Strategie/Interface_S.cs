using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISurgir<T>
{
    void Surgir(T[] PhantomList, T parent);
}

