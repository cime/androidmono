namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferOverflowException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferOverflowException()
		{
			InitJNI();
		}
		protected BufferOverflowException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BufferOverflowException16302;
		public BufferOverflowException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.BufferOverflowException.staticClass, global::java.nio.BufferOverflowException._BufferOverflowException16302);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.BufferOverflowException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/BufferOverflowException"));
			global::java.nio.BufferOverflowException._BufferOverflowException16302 = @__env.GetMethodIDNoThrow(global::java.nio.BufferOverflowException.staticClass, "<init>", "()V");
		}
	}
}
