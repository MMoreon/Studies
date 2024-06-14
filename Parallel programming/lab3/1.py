import pygame
import concurrent.futures
import numpy as np

# Параметры окна
WIDTH, HEIGHT = 640, 320
FPS = 60

# Параметры шара
BALL_SIZE = 10
NUM_BALLS = 5

# Начальные условия для шаров
balls = [{
    'pos': np.array([np.random.rand() * WIDTH, np.random.rand() * HEIGHT]),
    'vel': np.random.rand(2) * 2 - 1,
    'color': (255, 192, 203)  # Розовый цвет
} for _ in range(NUM_BALLS)]

def check_collision(balls):
    for i in range(len(balls)):
        for j in range(i + 1, len(balls)):
            if np.linalg.norm(balls[i]['pos'] - balls[j]['pos']) <= 2 * BALL_SIZE:
                handle_collision(balls[i], balls[j])
    return balls

def handle_collision(ball1, ball2):
    # Вычисление нормального и касательного вектора
    normal = ball2['pos'] - ball1['pos']
    normal_mag = np.linalg.norm(normal)
    normal = normal / normal_mag if normal_mag != 0 else np.array([0, 0])
    tangent = np.array([-normal[1], normal[0]])

    # Вычисление новых скоростей
    v1_normal = np.dot(ball1['vel'], normal) * normal
    v1_tangent = np.dot(ball1['vel'], tangent) * tangent
    v2_normal = np.dot(ball2['vel'], normal) * normal
    v2_tangent = np.dot(ball2['vel'], tangent) * tangent

    ball1['vel'] = v1_tangent + v2_normal
    ball2['vel'] = v2_tangent + v1_normal

def move_ball(ball):
    ball['pos'] += ball['vel']

    # Отражение от стен
    if ball['pos'][0] <= 0 or ball['pos'][0] >= WIDTH:
        ball['vel'][0] *= -1
    if ball['pos'][1] <= 0 or ball['pos'][1] >= HEIGHT:
        ball['vel'][1] *= -1
    return ball

def main():
    pygame.init()
    screen = pygame.display.set_mode((WIDTH, HEIGHT))
    clock = pygame.time.Clock()

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False

        # Параллельное вычисление новых позиций и проверка столкновений шаров
        with concurrent.futures.ThreadPoolExecutor() as executor:
            balls[:] = list(executor.map(move_ball, balls))
            balls[:] = check_collision(balls)

        # Отрисовка
        screen.fill((0, 0, 0))
        for ball in balls:
            pygame.draw.circle(screen, ball['color'], ball['pos'].astype(int), BALL_SIZE)

        pygame.display.flip()
        clock.tick(FPS)

    pygame.quit()

if __name__ == "__main__":
    main()
