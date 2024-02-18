project(Game)

include_directories(vendor/mono/include)

file(GLOB_RECURSE source_list "source/*.cpp" "include/*.h")

add_executable(Game ${source_list})

target_link_libraries(Game
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/eglib.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/libgcmonosgen.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/libmini-sgen.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/libmonoruntime-sgen.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/libmono-static-sgen.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/libmonoutils.lib
                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/mono-2.0-sgen.lib
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/lib/MonoPosixHelper.lib

#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/bin/MonoPosixHelper.dll
#                            ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/bin/mono-2.0-sgen.dll

)


add_custom_command(TARGET ${PROJECT_NAME}  POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy_directory
        ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/MonoLibs-4.5
        ${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/MonoLibs-4.5)

add_custom_command(
        TARGET ${PROJECT_NAME}  POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy
        ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/bin/mono-2.0-sgen.dll
        ${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/mono-2.0-sgen.dll)

add_custom_command(
        TARGET ${PROJECT_NAME}  POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy
        ${CMAKE_CURRENT_SOURCE_DIR}/vendor/mono/lib/bin/MonoPosixHelper.dll
        ${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/MonoPosixHelper.dll)

add_custom_command(
        TARGET ${PROJECT_NAME}  POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy
        ${CMAKE_CURRENT_SOURCE_DIR}/../CSharp/ClassLibrary/bin/Debug/ClassLibrary.dll
        ${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/ClassLibrary.dll)