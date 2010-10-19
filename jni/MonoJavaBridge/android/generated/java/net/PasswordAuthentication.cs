namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PasswordAuthentication : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PasswordAuthentication()
		{
			InitJNI();
		}
		internal PasswordAuthentication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword15953;
		public char[] getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.PasswordAuthentication._getPassword15953)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.PasswordAuthentication.staticClass, global::java.net.PasswordAuthentication._getPassword15953)) as char[];
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserName15954;
		public global::java.lang.String getUserName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.PasswordAuthentication._getUserName15954)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.PasswordAuthentication.staticClass, global::java.net.PasswordAuthentication._getUserName15954)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PasswordAuthentication15955;
		public PasswordAuthentication(java.lang.String arg0, char[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PasswordAuthentication.staticClass, global::java.net.PasswordAuthentication._PasswordAuthentication15955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.PasswordAuthentication.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/PasswordAuthentication"));
			global::java.net.PasswordAuthentication._getPassword15953 = @__env.GetMethodIDNoThrow(global::java.net.PasswordAuthentication.staticClass, "getPassword", "()[C");
			global::java.net.PasswordAuthentication._getUserName15954 = @__env.GetMethodIDNoThrow(global::java.net.PasswordAuthentication.staticClass, "getUserName", "()Ljava/lang/String;");
			global::java.net.PasswordAuthentication._PasswordAuthentication15955 = @__env.GetMethodIDNoThrow(global::java.net.PasswordAuthentication.staticClass, "<init>", "(Ljava/lang/String;[C)V");
		}
	}
}
