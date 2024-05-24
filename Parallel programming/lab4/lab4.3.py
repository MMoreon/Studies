import threading
import time
import random

class Philosopher(threading.Thread):
    def __init__(self, name, left_fork, right_fork):
        super().__init__()
        self.name = name
        self.left_fork = left_fork
        self.right_fork = right_fork

    def run(self):
        for i in range(3):  # каждый философ попытается поесть три раза
            self.think()
            self.eat()

    def think(self):
        print(f"{self.name} размышляет.")
        time.sleep(random.uniform(1, 3))

    def eat(self):
        print(f"{self.name} хочет поесть.")
        self.left_fork.acquire()
        self.right_fork.acquire()
        print(f"{self.name} ест.")
        time.sleep(random.uniform(1, 3))
        self.left_fork.release()
        self.right_fork.release()
        print(f"{self.name} закончил есть.")


if __name__ == "__main__":
    forks = [threading.Lock() for _ in range(5)]  # Создаем 5 вилок

    philosophers = []
    philosopher_names = ["Философ 1", "Философ 2", "Философ 3", "Философ 4", "Философ 5"]

    # Создаем философов
    for i in range(5):
        philosopher = Philosopher(philosopher_names[i], forks[i], forks[(i + 1) % 5])
        philosophers.append(philosopher)

    # Запускаем философов
    for philosopher in philosophers:
        philosopher.start()

    # Ждем, пока все философы закончат обедать
    for philosopher in philosophers:
        philosopher.join()

    print("Обед закончен.")
