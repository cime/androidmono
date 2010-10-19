namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMImplementationSource_))]
	public interface DOMImplementationSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String arg0);
		global::org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMImplementationSource))]
	public sealed partial class DOMImplementationSource_ : java.lang.Object, DOMImplementationSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMImplementationSource_()
		{
			InitJNI();
		}
		internal DOMImplementationSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementation27545;
		 global::org.w3c.dom.DOMImplementation org.w3c.dom.DOMImplementationSource.getDOMImplementation(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation27545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_.staticClass, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation27545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementation;
		}
		internal static global::MonoJavaBridge.MethodId _getDOMImplementationList27546;
		 global::org.w3c.dom.DOMImplementationList org.w3c.dom.DOMImplementationSource.getDOMImplementationList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementationList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList27546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementationList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementationList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DOMImplementationSource_.staticClass, global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList27546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.DOMImplementationList;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMImplementationSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMImplementationSource"));
			global::org.w3c.dom.DOMImplementationSource_._getDOMImplementation27545 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;");
			global::org.w3c.dom.DOMImplementationSource_._getDOMImplementationList27546 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMImplementationSource_.staticClass, "getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;");
		}
	}
}
