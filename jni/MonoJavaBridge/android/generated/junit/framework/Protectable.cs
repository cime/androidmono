namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.Protectable_))]
	public interface Protectable  : global::MonoJavaBridge.IJavaObject 
	{
		void protect();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.Protectable))]
	public sealed partial class Protectable_ : java.lang.Object, Protectable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Protectable_()
		{
			InitJNI();
		}
		internal Protectable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _protect24767;
		 void junit.framework.Protectable.protect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.Protectable_._protect24767);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.Protectable_.staticClass, global::junit.framework.Protectable_._protect24767);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Protectable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Protectable"));
			global::junit.framework.Protectable_._protect24767 = @__env.GetMethodIDNoThrow(global::junit.framework.Protectable_.staticClass, "protect", "()V");
		}
	}
}
