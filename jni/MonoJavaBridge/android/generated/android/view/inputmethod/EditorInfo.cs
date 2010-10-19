namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EditorInfo()
		{
			InitJNI();
		}
		protected EditorInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump10658;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._dump10658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._dump10658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10659;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._writeToParcel10659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._writeToParcel10659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10660;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._describeContents10660);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._describeContents10660);
		}
		internal static global::MonoJavaBridge.MethodId _EditorInfo10661;
		public EditorInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._EditorInfo10661);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _inputType10662;
		public int inputType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int IME_MASK_ACTION
		{
			get
			{
				return 255;
			}
		}
		public static int IME_ACTION_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int IME_ACTION_NONE
		{
			get
			{
				return 1;
			}
		}
		public static int IME_ACTION_GO
		{
			get
			{
				return 2;
			}
		}
		public static int IME_ACTION_SEARCH
		{
			get
			{
				return 3;
			}
		}
		public static int IME_ACTION_SEND
		{
			get
			{
				return 4;
			}
		}
		public static int IME_ACTION_NEXT
		{
			get
			{
				return 5;
			}
		}
		public static int IME_ACTION_DONE
		{
			get
			{
				return 6;
			}
		}
		public static int IME_FLAG_NO_EXTRACT_UI
		{
			get
			{
				return 268435456;
			}
		}
		public static int IME_FLAG_NO_ACCESSORY_ACTION
		{
			get
			{
				return 536870912;
			}
		}
		public static int IME_FLAG_NO_ENTER_ACTION
		{
			get
			{
				return 1073741824;
			}
		}
		public static int IME_NULL
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _imeOptions10663;
		public int imeOptions
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _privateImeOptions10664;
		public global::java.lang.String privateImeOptions
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionLabel10665;
		public global::java.lang.CharSequence actionLabel
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionId10666;
		public int actionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelStart10667;
		public int initialSelStart
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelEnd10668;
		public int initialSelEnd
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialCapsMode10669;
		public int initialCapsMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintText10670;
		public global::java.lang.CharSequence hintText
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label10671;
		public global::java.lang.CharSequence label
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName10672;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldId10673;
		public int fieldId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldName10674;
		public global::java.lang.String fieldName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras10675;
		public global::android.os.Bundle extras
		{
			get
			{
				return default(global::android.os.Bundle);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10676;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.EditorInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/EditorInfo"));
			global::android.view.inputmethod.EditorInfo._dump10658 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.EditorInfo._writeToParcel10659 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.EditorInfo._describeContents10660 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.EditorInfo._EditorInfo10661 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V");
		}
	}
}
