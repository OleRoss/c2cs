#include <stdio.h>
#include "ffi_helper.h"

typedef int some_alias[4];

struct struct_array
{
    some_alias a[4];
};

FFI_API_DECL struct struct_array struct_array;
