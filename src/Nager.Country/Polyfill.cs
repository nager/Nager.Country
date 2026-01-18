namespace System.Diagnostics.CodeAnalysis
{
    #if NETSTANDARD2_0 || NET48

    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.</summary>
    /// <remarks>https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/NullableAttributes.cs</remarks>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class NotNullWhenAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified return value condition.</summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>Gets the return value condition.</summary>
        public bool ReturnValue { get; }
    }

    /// <summary>Specifies that an output will not be null even if the corresponding type allows it. Specifies that an input argument was not null when the call returns.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
    internal sealed class NotNullAttribute : Attribute { }

    #endif //NETSTANDARD2_0 || NET48
}
