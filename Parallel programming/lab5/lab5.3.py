import multiprocessing

# Функция для чтения файла
def read_file(filename):
    with open(filename, 'r') as file:
        data = file.read()
    return data

# Функция для записи в файл
def write_file(filename, data):
    with open(filename, 'w') as file:
        file.write(data)

if __name__ == "__main__":
    # Имя файла для чтения и записи
    input_filename = 'input.txt'
    output_filename = 'output.txt'

    # Создаем процессы для чтения и записи файла
    read_process = multiprocessing.Process(target=read_file, args=(input_filename, ))
    write_process = multiprocessing.Process(target=write_file, args=(output_filename, "Some data to write."))

    # Запускаем процессы
    read_process.start()
    write_process.start()

    # Ждем завершения процессов
    read_process.join()
    write_process.join()

    print("Чтение и запись файла завершены.")
