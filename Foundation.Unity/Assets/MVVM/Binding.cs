using System;
using Foundation.Architecture;
using UnityEngine;

namespace MVVM
{
    public enum SourceType
    {
        /// <summary>
        /// Automagically find
        /// </summary>
        Inherent,

        /// <summary>
        /// A property within a inhereted class
        /// </summary>
        Property,

        /// <summary>
        /// Drag and drop
        /// </summary>
        Component,

        /// <summary>
        /// Set a runtime
        /// </summary>
        Runtime,
    }


    /// <summary>
    /// Required for MemberBinding. References the binding target.
    /// </summary>
    [Serializable]
    public class SourceBinding
    {
        /// <summary>
        /// Type of Source
        /// </summary>
        public SourceType Type;

        /// <summary>
        /// Instead of finding the parent, look for a custom source
        /// </summary>
        [SerializeField]
        public UnityEngine.Object CustomSource;

        /// <summary>
        /// Type of view model
        /// </summary>
        public Type ModelType;

        /// <summary>
        /// Reference to the view model. Set a runtime.
        /// </summary>
        public ObservableProxy ViewModel;
        
        public void Subscribe(Action<ObservableProxy> Handler)
        {

        }

        public void Post(string memberName, object value = null)
        {
            
        }

        public T Get<T>(string memberName)
        {
            return default(T);
        }
    }

    public enum MemberType
    {
        All,
        Methods,
        Properties
    }

    /// <summary>
    /// Constrain a binding. restricts the type of bindings that show up in the drop down
    /// </summary>
    public class MemberConstraint : Attribute
    {
        public MemberType Member;

        public Type[] WhiteList;

        public MemberConstraint(MemberType type)
        {
            Member = type;
        }

        public MemberConstraint(MemberType type, params Type[] whiteList)
        {
            Member = type;
            WhiteList = whiteList;
        }

        public MemberConstraint(params Type[] whiteList)
        {
            WhiteList = whiteList;
        }
    }
    
    

    /// <summary>
    /// Represents a single property binding
    /// </summary>
    [Serializable]
    public class MemberBinding
    {
        /// <summary>
        /// The specific member this binding is bound to
        /// </summary>
        [SerializeField]
        public string Member;



        public void Subscribe<T>(Action<T> Handler)
        {

        }

        public void Post(string memberName, object value = null)
        {

        }

        public T Get<T>(string memberName)
        {
            return default(T);
        }

    }
}