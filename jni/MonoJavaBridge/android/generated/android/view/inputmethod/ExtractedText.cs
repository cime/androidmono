namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractedText : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExtractedText()
		{
			InitJNI();
		}
		protected ExtractedText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10677;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText._writeToParcel10677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._writeToParcel10677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10678;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText._describeContents10678);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._describeContents10678);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractedText10679;
		public ExtractedText()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._ExtractedText10679);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _text10680;
		public global::java.lang.CharSequence text
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _startOffset10681;
		public int startOffset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialStartOffset10682;
		public int partialStartOffset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialEndOffset10683;
		public int partialEndOffset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionStart10684;
		public int selectionStart
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionEnd10685;
		public int selectionEnd
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int FLAG_SINGLE_LINE
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_SELECTING
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags10686;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10687;
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
			global::android.view.inputmethod.ExtractedText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedText"));
			global::android.view.inputmethod.ExtractedText._writeToParcel10677 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedText._describeContents10678 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedText._ExtractedText10679 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "<init>", "()V");
		}
	}
}
