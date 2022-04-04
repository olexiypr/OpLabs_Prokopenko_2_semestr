cmake_minimum_required(VERSION 3.20)
project(laba1)

set(CMAKE_CXX_STANDARD 14)

add_executable(laba1 main.cpp header.h changeText.cpp)
#set(SFML_STATIC_LIBRARIES TRUE)
#set(SFML_DIR C:/SFML/lib/cmake/SFML)
#find_package(SFML 2.5.1 COMPONENTS system window graphics audio REQUIRED)
#include_directories(c:/SFML/include)
#target_link_libraries(untitled12  sfml-graphics sfml-audio)