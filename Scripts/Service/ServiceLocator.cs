using ComputeWorkflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static ComputeProcessor _computeProcessor;

    public static ComputeProcessor ComputeProcessor => _computeProcessor;
}
