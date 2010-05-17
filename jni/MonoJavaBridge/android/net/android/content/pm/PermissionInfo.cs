namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PermissionInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PermissionInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PermissionInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.PermissionInfo(@__env); 
			} 
		} 
		protected PermissionInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1753; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1753)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PermissionInfo.staticClass, _toString1753)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1754; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PermissionInfo.staticClass, _writeToParcel1754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1755; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionInfo)) 
				return @__env.CallIntMethod(this, _describeContents1755); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.PermissionInfo.staticClass, _describeContents1755); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1756; 
		public virtual java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadDescription1756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PermissionInfo.staticClass, _loadDescription1756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionInfo1757; 
		public PermissionInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PermissionInfo.staticClass, _PermissionInfo1757, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionInfo1758; 
		public PermissionInfo(android.content.pm.PermissionInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PermissionInfo.staticClass, _PermissionInfo1758, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int PROTECTION_NORMAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PROTECTION_DANGEROUS
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PROTECTION_SIGNATURE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int PROTECTION_SIGNATURE_OR_SYSTEM
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _group1759; 
		public java.lang.String group
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1760; 
		public int descriptionRes
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedDescription1761; 
		public java.lang.CharSequence nonLocalizedDescription
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _protectionLevel1762; 
		public int protectionLevel
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1763; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PermissionInfo.staticClass = @__class; 
			global::android.content.pm.PermissionInfo._toString1753 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.PermissionInfo._writeToParcel1754 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.PermissionInfo._describeContents1755 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.PermissionInfo._loadDescription1756 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.PermissionInfo._PermissionInfo1757 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.PermissionInfo._PermissionInfo1758 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionInfo;)V"); 
		} 
	} 
} 
