namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class UriMatcher : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static UriMatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.UriMatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.UriMatcher(@__env); 
			} 
		} 
		protected UriMatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match1520; 
		public virtual int match(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.UriMatcher)) 
				return @__env.CallIntMethod(this, _match1520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.UriMatcher.staticClass, _match1520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addURI1521; 
		public virtual void addURI(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.UriMatcher)) 
				@__env.CallVoidMethod(this, _addURI1521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.UriMatcher.staticClass, _addURI1521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UriMatcher1522; 
		public UriMatcher(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.UriMatcher.staticClass, _UriMatcher1522, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		public static int NO_MATCH
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.UriMatcher.staticClass = @__class; 
			global::android.content.UriMatcher._match1520 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "match", "(Landroid/net/Uri;)I"); 
			global::android.content.UriMatcher._addURI1521 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "addURI", "(Ljava/lang/String;Ljava/lang/String;I)V"); 
			global::android.content.UriMatcher._UriMatcher1522 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 