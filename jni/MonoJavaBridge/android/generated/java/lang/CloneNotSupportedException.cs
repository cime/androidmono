namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CloneNotSupportedException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CloneNotSupportedException()
		{
			InitJNI();
		}
		protected CloneNotSupportedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CloneNotSupportedException14452;
		public CloneNotSupportedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.CloneNotSupportedException.staticClass, global::java.lang.CloneNotSupportedException._CloneNotSupportedException14452);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CloneNotSupportedException14453;
		public CloneNotSupportedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.CloneNotSupportedException.staticClass, global::java.lang.CloneNotSupportedException._CloneNotSupportedException14453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.CloneNotSupportedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/CloneNotSupportedException"));
			global::java.lang.CloneNotSupportedException._CloneNotSupportedException14452 = @__env.GetMethodIDNoThrow(global::java.lang.CloneNotSupportedException.staticClass, "<init>", "()V");
			global::java.lang.CloneNotSupportedException._CloneNotSupportedException14453 = @__env.GetMethodIDNoThrow(global::java.lang.CloneNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
