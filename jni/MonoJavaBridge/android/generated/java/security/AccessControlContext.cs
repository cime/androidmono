namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessControlContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessControlContext()
		{
			InitJNI();
		}
		internal AccessControlContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals17111;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.AccessControlContext._equals17111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._equals17111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17112;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.AccessControlContext._hashCode17112);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._hashCode17112);
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission17113;
		public void checkPermission(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AccessControlContext._checkPermission17113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._checkPermission17113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.DomainCombiner DomainCombiner
		{
			get
			{
				return getDomainCombiner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomainCombiner17114;
		public global::java.security.DomainCombiner getDomainCombiner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.DomainCombiner>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AccessControlContext._getDomainCombiner17114)) as java.security.DomainCombiner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.DomainCombiner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._getDomainCombiner17114)) as java.security.DomainCombiner;
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlContext17115;
		public AccessControlContext(java.security.ProtectionDomain[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._AccessControlContext17115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlContext17116;
		public AccessControlContext(java.security.AccessControlContext arg0, java.security.DomainCombiner arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._AccessControlContext17116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessControlContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessControlContext"));
			global::java.security.AccessControlContext._equals17111 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.AccessControlContext._hashCode17112 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "hashCode", "()I");
			global::java.security.AccessControlContext._checkPermission17113 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.security.AccessControlContext._getDomainCombiner17114 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "getDomainCombiner", "()Ljava/security/DomainCombiner;");
			global::java.security.AccessControlContext._AccessControlContext17115 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "([Ljava/security/ProtectionDomain;)V");
			global::java.security.AccessControlContext._AccessControlContext17116 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "(Ljava/security/AccessControlContext;Ljava/security/DomainCombiner;)V");
		}
	}
}
