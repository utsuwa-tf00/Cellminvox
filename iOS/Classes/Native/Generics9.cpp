﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct VirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Func`2<System.Object,System.Boolean>
struct Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8;
// System.Func`2<UnityEngine.UIElements.StyleSelectorPart,System.Boolean>
struct Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC;
// System.Func`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>
struct Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_t52B1AC8D9E5E1ED28DF6C46A37C9A1B00B394F9D;
// System.Collections.Generic.IEnumerator`1<System.Object>
struct IEnumerator_1_t2DC97C7D486BF9E077C2BC2E517E434F393AA76E;
// System.Linq.Enumerable/Iterator`1<System.Object>
struct Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279;
// System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart>
struct List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59;
// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>
struct WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// UnityEngine.UIElements.StyleSelectorPart[]
struct StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.String
struct String_t;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;

struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Linq.Enumerable/Iterator`1<System.Object>
struct  Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279  : public RuntimeObject
{
public:
	// System.Int32 System.Linq.Enumerable/Iterator`1::threadId
	int32_t ___threadId_0;
	// System.Int32 System.Linq.Enumerable/Iterator`1::state
	int32_t ___state_1;
	// TSource System.Linq.Enumerable/Iterator`1::current
	RuntimeObject * ___current_2;

public:
	inline static int32_t get_offset_of_threadId_0() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___threadId_0)); }
	inline int32_t get_threadId_0() const { return ___threadId_0; }
	inline int32_t* get_address_of_threadId_0() { return &___threadId_0; }
	inline void set_threadId_0(int32_t value)
	{
		___threadId_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_current_2() { return static_cast<int32_t>(offsetof(Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279, ___current_2)); }
	inline RuntimeObject * get_current_2() const { return ___current_2; }
	inline RuntimeObject ** get_address_of_current_2() { return &___current_2; }
	inline void set_current_2(RuntimeObject * value)
	{
		___current_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_2), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart>
struct  List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59, ____items_1)); }
	inline StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* get__items_1() const { return ____items_1; }
	inline StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59_StaticFields, ____emptyArray_5)); }
	inline StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* get__emptyArray_5() const { return ____emptyArray_5; }
	inline StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(StyleSelectorPartU5BU5D_tD8762DADE4104C7D73D7B821DF7E5BBC87417BB7* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// System.ValueType
struct  ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Linq.Enumerable/WhereEnumerableIterator`1<System.Object>
struct  WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::source
	RuntimeObject* ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereEnumerableIterator`1::predicate
	Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate_4;
	// System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::enumerator
	RuntimeObject* ___enumerator_5;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___source_3)); }
	inline RuntimeObject* get_source_3() const { return ___source_3; }
	inline RuntimeObject** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(RuntimeObject* value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___predicate_4)); }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_5() { return static_cast<int32_t>(offsetof(WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0, ___enumerator_5)); }
	inline RuntimeObject* get_enumerator_5() const { return ___enumerator_5; }
	inline RuntimeObject** get_address_of_enumerator_5() { return &___enumerator_5; }
	inline void set_enumerator_5(RuntimeObject* value)
	{
		___enumerator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumerator_5), (void*)value);
	}
};


// System.Boolean
struct  Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct  Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Int32
struct  Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Void
struct  Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.Delegate
struct  Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * get_data_9() const { return ___data_9; }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};

// UnityEngine.UIElements.StyleSelectorType
struct  StyleSelectorType_t076854E4D0D1DE5408564915375B2D4AF5F13BD7 
{
public:
	// System.Int32 UnityEngine.UIElements.StyleSelectorType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StyleSelectorType_t076854E4D0D1DE5408564915375B2D4AF5F13BD7, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// UnityEngine.UIElements.StyleSelectorPart
struct  StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 
{
public:
	// System.String UnityEngine.UIElements.StyleSelectorPart::m_Value
	String_t* ___m_Value_0;
	// UnityEngine.UIElements.StyleSelectorType UnityEngine.UIElements.StyleSelectorPart::m_Type
	int32_t ___m_Type_1;
	// System.Object UnityEngine.UIElements.StyleSelectorPart::tempData
	RuntimeObject * ___tempData_2;

public:
	inline static int32_t get_offset_of_m_Value_0() { return static_cast<int32_t>(offsetof(StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54, ___m_Value_0)); }
	inline String_t* get_m_Value_0() const { return ___m_Value_0; }
	inline String_t** get_address_of_m_Value_0() { return &___m_Value_0; }
	inline void set_m_Value_0(String_t* value)
	{
		___m_Value_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Value_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Type_1() { return static_cast<int32_t>(offsetof(StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54, ___m_Type_1)); }
	inline int32_t get_m_Type_1() const { return ___m_Type_1; }
	inline int32_t* get_address_of_m_Type_1() { return &___m_Type_1; }
	inline void set_m_Type_1(int32_t value)
	{
		___m_Type_1 = value;
	}

	inline static int32_t get_offset_of_tempData_2() { return static_cast<int32_t>(offsetof(StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54, ___tempData_2)); }
	inline RuntimeObject * get_tempData_2() const { return ___tempData_2; }
	inline RuntimeObject ** get_address_of_tempData_2() { return &___tempData_2; }
	inline void set_tempData_2(RuntimeObject * value)
	{
		___tempData_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tempData_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.UIElements.StyleSelectorPart
struct StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54_marshaled_pinvoke
{
	char* ___m_Value_0;
	int32_t ___m_Type_1;
	Il2CppIUnknown* ___tempData_2;
};
// Native definition for COM marshalling of UnityEngine.UIElements.StyleSelectorPart
struct StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54_marshaled_com
{
	Il2CppChar* ___m_Value_0;
	int32_t ___m_Type_1;
	Il2CppIUnknown* ___tempData_2;
};

// System.Collections.Generic.List`1/Enumerator<UnityEngine.UIElements.StyleSelectorPart>
struct  Enumerator_tC861559498255F6677610CED32D2161012D8D897 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tC861559498255F6677610CED32D2161012D8D897, ___list_0)); }
	inline List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * get_list_0() const { return ___list_0; }
	inline List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tC861559498255F6677610CED32D2161012D8D897, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tC861559498255F6677610CED32D2161012D8D897, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tC861559498255F6677610CED32D2161012D8D897, ___current_3)); }
	inline StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  get_current_3() const { return ___current_3; }
	inline StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___m_Value_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___tempData_2), (void*)NULL);
		#endif
	}
};


// System.Func`2<System.Object,System.Boolean>
struct  Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.UIElements.StyleSelectorPart,System.Boolean>
struct  Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>
struct  Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957  : public MulticastDelegate_t
{
public:

public:
};


// System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>
struct  WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798  : public Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279
{
public:
	// System.Collections.Generic.List`1<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::source
	List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * ___source_3;
	// System.Func`2<TSource,System.Boolean> System.Linq.Enumerable/WhereSelectListIterator`2::predicate
	Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * ___predicate_4;
	// System.Func`2<TSource,TResult> System.Linq.Enumerable/WhereSelectListIterator`2::selector
	Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * ___selector_5;
	// System.Collections.Generic.List`1/Enumerator<TSource> System.Linq.Enumerable/WhereSelectListIterator`2::enumerator
	Enumerator_tC861559498255F6677610CED32D2161012D8D897  ___enumerator_6;

public:
	inline static int32_t get_offset_of_source_3() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798, ___source_3)); }
	inline List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * get_source_3() const { return ___source_3; }
	inline List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 ** get_address_of_source_3() { return &___source_3; }
	inline void set_source_3(List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * value)
	{
		___source_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___source_3), (void*)value);
	}

	inline static int32_t get_offset_of_predicate_4() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798, ___predicate_4)); }
	inline Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * get_predicate_4() const { return ___predicate_4; }
	inline Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC ** get_address_of_predicate_4() { return &___predicate_4; }
	inline void set_predicate_4(Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * value)
	{
		___predicate_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___predicate_4), (void*)value);
	}

	inline static int32_t get_offset_of_selector_5() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798, ___selector_5)); }
	inline Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * get_selector_5() const { return ___selector_5; }
	inline Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 ** get_address_of_selector_5() { return &___selector_5; }
	inline void set_selector_5(Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * value)
	{
		___selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_enumerator_6() { return static_cast<int32_t>(offsetof(WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798, ___enumerator_6)); }
	inline Enumerator_tC861559498255F6677610CED32D2161012D8D897  get_enumerator_6() const { return ___enumerator_6; }
	inline Enumerator_tC861559498255F6677610CED32D2161012D8D897 * get_address_of_enumerator_6() { return &___enumerator_6; }
	inline void set_enumerator_6(Enumerator_tC861559498255F6677610CED32D2161012D8D897  value)
	{
		___enumerator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___enumerator_6))->___list_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___m_Value_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___enumerator_6))->___current_3))->___tempData_2), (void*)NULL);
		#endif
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif


// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.UIElements.StyleSelectorPart>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  Enumerator_get_Current_mEE518BAF9575D30AF8E5D39A599B90BD6B796AC5_gshared_inline (Enumerator_tC861559498255F6677610CED32D2161012D8D897 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.UIElements.StyleSelectorPart>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mC5D34E64D92EABA8FE6CD4D97FF07A35F7F0DF25_gshared (Enumerator_tC861559498255F6677610CED32D2161012D8D897 * __this, const RuntimeMethod* method);

// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.UIElements.StyleSelectorPart>::get_Current()
inline StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  Enumerator_get_Current_mEE518BAF9575D30AF8E5D39A599B90BD6B796AC5_inline (Enumerator_tC861559498255F6677610CED32D2161012D8D897 * __this, const RuntimeMethod* method)
{
	return ((  StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  (*) (Enumerator_tC861559498255F6677610CED32D2161012D8D897 *, const RuntimeMethod*))Enumerator_get_Current_mEE518BAF9575D30AF8E5D39A599B90BD6B796AC5_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.UIElements.StyleSelectorPart>::MoveNext()
inline bool Enumerator_MoveNext_mC5D34E64D92EABA8FE6CD4D97FF07A35F7F0DF25 (Enumerator_tC861559498255F6677610CED32D2161012D8D897 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tC861559498255F6677610CED32D2161012D8D897 *, const RuntimeMethod*))Enumerator_MoveNext_mC5D34E64D92EABA8FE6CD4D97FF07A35F7F0DF25_gshared)(__this, method);
}
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WhereSelectListIterator_2__ctor_m42EC49735B7C7E046D4C40F2356951E7C8DE55E1_gshared (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 * __this, List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * ___source0, Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * ___predicate1, Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * ___selector2, const RuntimeMethod* method)
{
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		((  void (*) (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0)->methodPointer)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 0));
		List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * L_0 = ___source0;
		__this->set_source_3(L_0);
		Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * L_1 = ___predicate1;
		__this->set_predicate_4(L_1);
		Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * L_2 = ___selector2;
		__this->set_selector_5(L_2);
		return;
	}
}
// System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 * WhereSelectListIterator_2_Clone_m948D6D8640F7ECBA7E181A5E6428ED75B720A1B8_gshared (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 * __this, const RuntimeMethod* method)
{
	{
		List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * L_0 = (List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *)__this->get_source_3();
		Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * L_1 = (Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)__this->get_predicate_4();
		Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * L_2 = (Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *)__this->get_selector_5();
		WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 * L_3 = (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 2));
		((  void (*) (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 *, List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *, Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *, Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3)->methodPointer)(L_3, (List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *)L_0, (Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)L_1, (Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *)L_2, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 3));
		return (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)L_3;
	}
}
// System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WhereSelectListIterator_2_MoveNext_m0A73EF53DDB09F1752547E23BDC8C82C057D7D42_gshared (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = (int32_t)((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->get_state_1();
		V_0 = (int32_t)L_0;
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			goto IL_0061;
		}
	}
	{
		goto IL_0074;
	}

IL_0011:
	{
		List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 * L_3 = (List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *)__this->get_source_3();
		NullCheck((List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *)L_3);
		Enumerator_tC861559498255F6677610CED32D2161012D8D897  L_4;
		L_4 = ((  Enumerator_tC861559498255F6677610CED32D2161012D8D897  (*) (List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4)->methodPointer)((List_1_tE7DC2F192C483F9E5722779E3C2C1910490AAE59 *)L_3, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 4));
		__this->set_enumerator_6(L_4);
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_state_1(2);
		goto IL_0061;
	}

IL_002b:
	{
		Enumerator_tC861559498255F6677610CED32D2161012D8D897 * L_5 = (Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)__this->get_address_of_enumerator_6();
		StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  L_6;
		L_6 = Enumerator_get_Current_mEE518BAF9575D30AF8E5D39A599B90BD6B796AC5_inline((Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)(Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)L_5, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 5));
		V_1 = (StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 )L_6;
		Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * L_7 = (Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)__this->get_predicate_4();
		if (!L_7)
		{
			goto IL_004d;
		}
	}
	{
		Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC * L_8 = (Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)__this->get_predicate_4();
		StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  L_9 = V_1;
		NullCheck((Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)L_8);
		bool L_10;
		L_10 = ((  bool (*) (Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *, StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6)->methodPointer)((Func_2_t0A3D12C95DB15867D9D7D83394FF45A41B67FDAC *)L_8, (StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 )L_9, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 6));
		if (!L_10)
		{
			goto IL_0061;
		}
	}

IL_004d:
	{
		Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 * L_11 = (Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *)__this->get_selector_5();
		StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  L_12 = V_1;
		NullCheck((Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *)L_11);
		RuntimeObject * L_13;
		L_13 = ((  RuntimeObject * (*) (Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *, StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 , const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7)->methodPointer)((Func_2_t43979C5A872BA9ED7A923D533A01683A98D71957 *)L_11, (StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 )L_12, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 7));
		((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this)->set_current_2(L_13);
		return (bool)1;
	}

IL_0061:
	{
		Enumerator_tC861559498255F6677610CED32D2161012D8D897 * L_14 = (Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)__this->get_address_of_enumerator_6();
		bool L_15;
		L_15 = Enumerator_MoveNext_mC5D34E64D92EABA8FE6CD4D97FF07A35F7F0DF25((Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)(Enumerator_tC861559498255F6677610CED32D2161012D8D897 *)L_14, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 8));
		if (L_15)
		{
			goto IL_002b;
		}
	}
	{
		NullCheck((Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
		VirtualActionInvoker0::Invoke(12 /* System.Void System.Linq.Enumerable/Iterator`1<System.Object>::Dispose() */, (Iterator_1_t674ABE41CF4096D4BE4D51E21FEBDADBF74CC279 *)__this);
	}

IL_0074:
	{
		return (bool)0;
	}
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2<UnityEngine.UIElements.StyleSelectorPart,System.Object>::Where(System.Func`2<TResult,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WhereSelectListIterator_2_Where_m6B81858AD8958A42F481DD06A8844FC2B67AF736_gshared (WhereSelectListIterator_2_t0F9C36BA8F331B1C4C968AB639F343F642078798 * __this, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate0, const RuntimeMethod* method)
{
	{
		Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * L_0 = ___predicate0;
		WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 * L_1 = (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *)il2cpp_codegen_object_new(IL2CPP_RGCTX_DATA(method->klass->rgctx_data, 10));
		((  void (*) (WhereEnumerableIterator_1_t1E9FDCFD8F8136C6A5A5740C1E093EF03F0B5CE0 *, RuntimeObject*, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *, const RuntimeMethod*))IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11)->methodPointer)(L_1, (RuntimeObject*)__this, (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(method->klass->rgctx_data, 11));
		return (RuntimeObject*)L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  Enumerator_get_Current_mEE518BAF9575D30AF8E5D39A599B90BD6B796AC5_gshared_inline (Enumerator_tC861559498255F6677610CED32D2161012D8D897 * __this, const RuntimeMethod* method)
{
	{
		StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54  L_0 = (StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 )__this->get_current_3();
		return (StyleSelectorPart_t707EDC970FC0F3E91E56DCBC178672A120426D54 )L_0;
	}
}
