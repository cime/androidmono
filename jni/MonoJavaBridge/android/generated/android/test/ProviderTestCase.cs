namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ProviderTestCase_))]
	public abstract partial class ProviderTestCase : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderTestCase()
		{
			InitJNI();
		}
		protected ProviderTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProvider7739;
		public virtual global::android.content.ContentProvider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase._getProvider7739)) as android.content.ContentProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getProvider7739)) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setUp7740;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ProviderTestCase._setUp7740);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._setUp7740);
		}
		internal static global::MonoJavaBridge.MethodId _getMockContentResolver7741;
		public virtual global::android.test.mock.MockContentResolver getMockContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase._getMockContentResolver7741)) as android.test.mock.MockContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getMockContentResolver7741)) as android.test.mock.MockContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getMockContext7742;
		public virtual global::android.test.IsolatedContext getMockContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase._getMockContext7742)) as android.test.IsolatedContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getMockContext7742)) as android.test.IsolatedContext;
		}
		internal static global::MonoJavaBridge.MethodId _newResolverWithContentProviderFromSql7743;
		public static global::android.content.ContentResolver newResolverWithContentProviderFromSql(android.content.Context arg0, java.lang.Class arg1, java.lang.String arg2, java.lang.String arg3, int arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._newResolverWithContentProviderFromSql7743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.content.ContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _ProviderTestCase7744;
		public ProviderTestCase(java.lang.Class arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._ProviderTestCase7744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase"));
			global::android.test.ProviderTestCase._getProvider7739 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getProvider", "()Landroid/content/ContentProvider;");
			global::android.test.ProviderTestCase._setUp7740 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "setUp", "()V");
			global::android.test.ProviderTestCase._getMockContentResolver7741 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getMockContentResolver", "()Landroid/test/mock/MockContentResolver;");
			global::android.test.ProviderTestCase._getMockContext7742 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getMockContext", "()Landroid/test/IsolatedContext;");
			global::android.test.ProviderTestCase._newResolverWithContentProviderFromSql7743 = @__env.GetStaticMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Landroid/content/ContentResolver;");
			global::android.test.ProviderTestCase._ProviderTestCase7744 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ProviderTestCase))]
	public sealed partial class ProviderTestCase_ : android.test.ProviderTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderTestCase_()
		{
			InitJNI();
		}
		internal ProviderTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase"));
		}
	}
}
