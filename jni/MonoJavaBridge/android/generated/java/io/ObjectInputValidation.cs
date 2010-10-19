namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectInputValidation_))]
	public interface ObjectInputValidation  : global::MonoJavaBridge.IJavaObject 
	{
		void validateObject();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputValidation))]
	public sealed partial class ObjectInputValidation_ : java.lang.Object, ObjectInputValidation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectInputValidation_()
		{
			InitJNI();
		}
		internal ObjectInputValidation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _validateObject13630;
		 void java.io.ObjectInputValidation.validateObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputValidation_._validateObject13630);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputValidation_.staticClass, global::java.io.ObjectInputValidation_._validateObject13630);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputValidation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputValidation"));
			global::java.io.ObjectInputValidation_._validateObject13630 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputValidation_.staticClass, "validateObject", "()V");
		}
	}
}
