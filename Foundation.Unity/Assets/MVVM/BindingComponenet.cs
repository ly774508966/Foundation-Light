//using System.Collections.Generic;
//using Foundation.Architecture;
//using MVVM;
//using UnityEngine;

///// <summary>
///// Base class for all binders
///// </summary>
//[AddComponentMenu("PierPlay/Binding/BindingComponenet")]
//public class BindingComponenet : MonoBehaviour
//{
//    /// <summary>
//    /// Find Context override
//    /// </summary>
//    public Component Target;

//    /// <summary>
//    /// Collection of all bindings avaliable for targeting
//    /// </summary>
//  //  public List<Binding> Bindings;

//    /// <summary>
//    /// The 'view model' we are bound to
//    /// </summary>
//    public ObservableProxy Context;

//  //  private IObservableView view;

//    public void Init()
//    {
//        if (Target == null)
//            FindTarget();

//        BindTarget();
//    }

//    void FindTarget()
//    {
//    //    Target = this.GetComponentInParent<IObservableView>() as Component;
//    }

//    void BindTarget()
//    {
//    //    if (view != null)
//    //    {
//    //        view.Unsubscribe(OnContext);
//    //    }

//    //  //  view = Target as IObservableView;

//    //    if (view != null)
//    //    {
//    //        view.Subscribe(OnContext);
//    //    }
//    }

//    void OnContext(ObservableProxy proxy)
//    {
//        //if (Context != null)
//        //{
//        //    Context.OnPropertyChanged -= Context_OnPropertyChanged;
//        //}

//        //Context = proxy;

//        //if (Context != null)
//        //{
//        //    Context.OnPropertyChanged += Context_OnPropertyChanged;
//        //}
//    }

//    private void Context_OnPropertyChanged(string memberName)
//    {
//        if (Bindings == null)
//            return;
//        for (int i = 0; i < Bindings.Count; i++)
//        {
//            if (Bindings[i].Member == memberName)
//            {
//                OnChanged(memberName);
//                return;
//            }
//        }
//    }

//    /// <summary>
//    /// Handle any/all property changes here
//    /// </summary>
//    /// <param name="memberName"></param>
//    public virtual void OnChanged(string memberName)
//    {

//    }

//    /// <summary>
//    /// Post changes to the view model here
//    /// </summary>
//    /// <param name="memberName"></param>
//    /// <param name="value"></param>
//    public void Post(string memberName, object value = null)
//    {
//        if (Context == null)
//        {
//            return;
//        }

//      //  Context.Set();
//    }
//}
