namespace android.text.format 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Formatter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Formatter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.format.Formatter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.format.Formatter(@__env); 
			} 
		} 
		internal Formatter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatFileSize6711; 
		public static java.lang.String formatFileSize(android.content.Context arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, _formatFileSize6711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatShortFileSize6712; 
		public static java.lang.String formatShortFileSize(android.content.Context arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, _formatShortFileSize6712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatIpAddress6713; 
		public static java.lang.String formatIpAddress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Formatter.staticClass, _formatIpAddress6713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter6714; 
		public Formatter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.format.Formatter.staticClass, _Formatter6714, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.format.Formatter.staticClass = @__class; 
			global::android.text.format.Formatter._formatFileSize6711 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;"); 
			global::android.text.format.Formatter._formatShortFileSize6712 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;"); 
			global::android.text.format.Formatter._formatIpAddress6713 = @__env.GetStaticMethodID(global::android.text.format.Formatter.staticClass, "formatIpAddress", "(I)Ljava/lang/String;"); 
			global::android.text.format.Formatter._Formatter6714 = @__env.GetMethodID(global::android.text.format.Formatter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
