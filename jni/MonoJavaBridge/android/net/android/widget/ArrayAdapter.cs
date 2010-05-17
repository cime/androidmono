namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ArrayAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ArrayAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ArrayAdapter(@__env); 
			} 
		} 
		protected ArrayAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add9153; 
		public virtual void add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _add9153, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _add9153, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear9154; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _clear9154); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _clear9154); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove9155; 
		public virtual void remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _remove9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _remove9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext9156; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext9156)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ArrayAdapter.staticClass, _getContext9156)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert9157; 
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _insert9157, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _insert9157, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort9158; 
		public virtual void sort(java.util.Comparator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _sort9158, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _sort9158, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition9159; 
		public virtual int getPosition(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return @__env.CallIntMethod(this, _getPosition9159, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ArrayAdapter.staticClass, _getPosition9159, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9160; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return @__env.CallIntMethod(this, _getCount9160); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ArrayAdapter.staticClass, _getCount9160); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9161; 
		public override java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem9161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ArrayAdapter.staticClass, _getItem9161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9162; 
		public override long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return @__env.CallLongMethod(this, _getItemId9162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.ArrayAdapter.staticClass, _getItemId9162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9163; 
		public virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter9163)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ArrayAdapter.staticClass, _getFilter9163)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView9164; 
		public override android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView9164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ArrayAdapter.staticClass, _getView9164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView9165; 
		public override android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownView9165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ArrayAdapter.staticClass, _getDropDownView9165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9166; 
		public override void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetChanged9166); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _notifyDataSetChanged9166); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotifyOnChange9167; 
		public virtual void setNotifyOnChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _setNotifyOnChange9167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _setNotifyOnChange9167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource9168; 
		public virtual void setDropDownViewResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ArrayAdapter)) 
				@__env.CallVoidMethod(this, _setDropDownViewResource9168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ArrayAdapter.staticClass, _setDropDownViewResource9168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResource9169; 
		public static android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ArrayAdapter>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ArrayAdapter.staticClass, _createFromResource9169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9170; 
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9170, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9171; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9171, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9172; 
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9172, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9173; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9173, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9174; 
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9174, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter9175; 
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, _ArrayAdapter9175, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ArrayAdapter.staticClass = @__class; 
			global::android.widget.ArrayAdapter._add9153 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._clear9154 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "clear", "()V"); 
			global::android.widget.ArrayAdapter._remove9155 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._getContext9156 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.widget.ArrayAdapter._insert9157 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V"); 
			global::android.widget.ArrayAdapter._sort9158 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V"); 
			global::android.widget.ArrayAdapter._getPosition9159 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I"); 
			global::android.widget.ArrayAdapter._getCount9160 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.ArrayAdapter._getItem9161 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.ArrayAdapter._getItemId9162 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.ArrayAdapter._getFilter9163 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.ArrayAdapter._getView9164 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ArrayAdapter._getDropDownView9165 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.ArrayAdapter._notifyDataSetChanged9166 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.ArrayAdapter._setNotifyOnChange9167 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V"); 
			global::android.widget.ArrayAdapter._setDropDownViewResource9168 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V"); 
			global::android.widget.ArrayAdapter._createFromResource9169 = @__env.GetStaticMethodID(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9170 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9171 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9172 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9173 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9174 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V"); 
			global::android.widget.ArrayAdapter._ArrayAdapter9175 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V"); 
		} 
	} 
} 
