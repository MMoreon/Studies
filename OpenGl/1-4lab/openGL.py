import pygame
from pygame.locals import *
from OpenGL.GL import *
from OpenGL.GLU import *
 
def Snowman(sphere1, sphere2, sphere3):
    glPushMatrix()
    glTranslatef(0.0, 0.0, 0.0) # начальное положение

    # glColor3f(1.0, 1.0, 1.0)  # устанавливаем цвет снеговика

    # ноги
    glTranslatef(0.0, 0.0, 0.0)
    gluSphere(sphere1, 1.5, 32, 32)

    # тело
    glTranslatef(0.0, 2.0, 0.0)
    gluSphere(sphere2, 1.0, 32, 32)

    # голова
    glTranslatef(0.0, 1.3, 0.0)
    gluSphere(sphere3, 0.5, 32, 32)



    def texture_snow():
        # Загрузка текстуры на сферы
        snow = pygame.image.load('metallic.jpg')
        texture_data1 = pygame.image.tostring(snow, "RGBA", 1)
        width = snow.get_width()
        height = snow.get_height()
        # Создание объекта текстуры сфер
        texture_id1 = glGenTextures(1)
        glBindTexture(GL_TEXTURE_2D, texture_id1)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
        glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, texture_data1) # rust добавить так же надо
        # Привязка текстуры и установка текстурных координат сфер
        glEnable(GL_TEXTURE_2D)
        gluQuadricTexture(sphere1, GLU_TRUE)  # Включение текстурирования для сферы
        gluQuadricTexture(sphere2, GLU_TRUE)
        gluQuadricTexture(sphere3, GLU_TRUE)
    
    texture_snow()
        
    
        

def attribute(cylinder1):
        # Цилиндр на голове
    glTranslatef(0.0, 0.9, 0.0)
    glRotatef(90, 1, 0, 0)
    # glColor3f(0.2, 0.2, 0.2)  # серый цвет
    gluCylinder(cylinder1, 0.45, 0.55, 0.6, 32, 32)  # параметры: радиус верхнего основания, радиус нижнего основания, высота, количество сегментов



    def texture_rust():
        rust = pygame.image.load('carrot.jpg')
        texture_data2 = pygame.image.tostring(rust, "RGBA", 1)
        width = rust.get_width()
        height = rust.get_height()

        texture_id2 = glGenTextures(1)
        glBindTexture(GL_TEXTURE_2D, texture_id2)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
        glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, texture_data2)
        glEnable(GL_TEXTURE_2D)
        gluQuadricTexture(cylinder1, GLU_TRUE)

    # glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_MODULATE)

    texture_rust()

def nose(cylinder2):
        # Цилиндр на нос
    glTranslatef(0, 0.9, 1)
    glRotatef(90, 1, 0, 0)
    # glColor3f(1, 0.5, 0)  # оранжевый цвет
    gluCylinder(cylinder2, 0.0, 0.1, 0.6, 4, 4)

    def texture():
        rust = pygame.image.load('snow.png')
        texture_data2 = pygame.image.tostring(rust, "RGBA", 1)
        width = rust.get_width()
        height = rust.get_height()

        texture_id2 = glGenTextures(1)
        glBindTexture(GL_TEXTURE_2D, texture_id2)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
        glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, texture_data2)
        glEnable(GL_TEXTURE_2D)
        gluQuadricTexture(cylinder2, GLU_TRUE)

    # glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_MODULATE)
    glPopMatrix()
    texture()    
    



def main():
    pygame.init()
    display = (1080, 720)
    pygame.display.set_mode(display, DOUBLEBUF|OPENGL)

    # Инициализация буфера глубины
    glEnable(GL_DEPTH_TEST)

    gluPerspective(45, (display[0]/display[1]), 0.1, 50.0)

    sphere1 = gluNewQuadric()
    sphere2 = gluNewQuadric()
    sphere3 = gluNewQuadric()
    cylinder1 = gluNewQuadric()
    cylinder2 = gluNewQuadric()

    glTranslatef(0.0, -1.0, -10)
    glRotatef(20, 10, 0, 0)

    rotation_enabled = False
    current_rotation_axis = (0, 1, 0)  # Начальная ось вращения

    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                quit()
            elif event.type == pygame.MOUSEBUTTONDOWN and event.button == 3:  # Правая кнопка мыши
                rotation_enabled = not rotation_enabled  # Переключение режима вращения

            elif event.type == pygame.KEYDOWN:
                if event.key == pygame.K_SPACE:  # Клавиша "пробел"
                    # Изменение оси вращения на основе текущей оси
                    if current_rotation_axis == (0, 1, 0):
                        current_rotation_axis = (1, 0, 0)
                    elif current_rotation_axis == (1, 0, 0):
                        current_rotation_axis = (0, 0, 1)
                    else:
                        current_rotation_axis = (0, 1, 0)

        if rotation_enabled:
            glRotatef(1, *current_rotation_axis)  # Применение вращения, если включено

        glClear(GL_COLOR_BUFFER_BIT|GL_DEPTH_BUFFER_BIT)   # Очистка буфера глубины
        Snowman(sphere1, sphere2, sphere3)
        attribute(cylinder1)
        nose(cylinder2)

        pygame.display.flip()
        pygame.time.wait(10)

main()