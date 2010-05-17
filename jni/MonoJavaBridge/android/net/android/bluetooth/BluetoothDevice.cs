namespace android.bluetooth 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class BluetoothDevice : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BluetoothDevice() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothDevice), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.bluetooth.BluetoothDevice(@__env); 
			} 
		} 
		internal BluetoothDevice(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode877; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return @__env.CallIntMethod(this, _hashCode877); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothDevice.staticClass, _hashCode877); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals878; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return @__env.CallBooleanMethod(this, _equals878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothDevice.staticClass, _equals878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress879; 
		public java.lang.String getAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAddress879)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothDevice.staticClass, _getAddress879)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString880; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString880)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothDevice.staticClass, _toString880)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName881; 
		public java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName881)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothDevice.staticClass, _getName881)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel882; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				@__env.CallVoidMethod(this, _writeToParcel882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.bluetooth.BluetoothDevice.staticClass, _writeToParcel882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents883; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return @__env.CallIntMethod(this, _describeContents883); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothDevice.staticClass, _describeContents883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBondState884; 
		public int getBondState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return @__env.CallIntMethod(this, _getBondState884); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothDevice.staticClass, _getBondState884); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBluetoothClass885; 
		public android.bluetooth.BluetoothClass getBluetoothClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothClass>(@__env, @__env.CallObjectMethodPtr(this, _getBluetoothClass885)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothDevice.staticClass, _getBluetoothClass885)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createRfcommSocketToServiceRecord886; 
		public android.bluetooth.BluetoothSocket createRfcommSocketToServiceRecord(java.util.UUID arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothDevice)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallObjectMethodPtr(this, _createRfcommSocketToServiceRecord886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothDevice.staticClass, _createRfcommSocketToServiceRecord886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static int ERROR
		{ 
			get 
			{ 
				return -2147483648; 
			} 
		} 
		public static java.lang.String ACTION_FOUND
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.FOUND"; 
			} 
		} 
		public static java.lang.String ACTION_CLASS_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.CLASS_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_ACL_CONNECTED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.ACL_CONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_ACL_DISCONNECT_REQUESTED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.ACL_DISCONNECT_REQUESTED"; 
			} 
		} 
		public static java.lang.String ACTION_ACL_DISCONNECTED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.ACL_DISCONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_NAME_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.NAME_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_BOND_STATE_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.device.action.BOND_STATE_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_DEVICE
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.DEVICE"; 
			} 
		} 
		public static java.lang.String EXTRA_NAME
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.NAME"; 
			} 
		} 
		public static java.lang.String EXTRA_RSSI
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.RSSI"; 
			} 
		} 
		public static java.lang.String EXTRA_CLASS
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.CLASS"; 
			} 
		} 
		public static java.lang.String EXTRA_BOND_STATE
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.BOND_STATE"; 
			} 
		} 
		public static java.lang.String EXTRA_PREVIOUS_BOND_STATE
		{ 
			get 
			{ 
				return "android.bluetooth.device.extra.PREVIOUS_BOND_STATE"; 
			} 
		} 
		public static int BOND_NONE
		{ 
			get 
			{ 
				return 10; 
			} 
		} 
		public static int BOND_BONDING
		{ 
			get 
			{ 
				return 11; 
			} 
		} 
		public static int BOND_BONDED
		{ 
			get 
			{ 
				return 12; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR887; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothDevice.staticClass = @__class; 
			global::android.bluetooth.BluetoothDevice._hashCode877 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "hashCode", "()I"); 
			global::android.bluetooth.BluetoothDevice._equals878 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.bluetooth.BluetoothDevice._getAddress879 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getAddress", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothDevice._toString880 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothDevice._getName881 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothDevice._writeToParcel882 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.bluetooth.BluetoothDevice._describeContents883 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "describeContents", "()I"); 
			global::android.bluetooth.BluetoothDevice._getBondState884 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getBondState", "()I"); 
			global::android.bluetooth.BluetoothDevice._getBluetoothClass885 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;"); 
			global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord886 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;"); 
		} 
	} 
} 