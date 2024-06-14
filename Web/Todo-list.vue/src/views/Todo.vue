<script setup>
// Эта часть выполняется при первоначальной загрузке компонента
</script>


<template>
    <div>
        <h2>Список задач</h2>
        <ul>
            <li v-for="task in tasks" :key="task.id">{{ task.text }}</li>
        </ul>
    </div>
</template>

<script>
export default {
    data() {
        return {
            tasks: [
                { id: 1, text: 'Постирать белье' },
                { id: 2, text: 'Сходить в магазин' },
                { id: 3, text: 'Заплатить счета' }
            ]
        };
    }
}
</script>

<style scoped>
/* Стили для компонента Todo.vue */
ul {
    list-style-type: none;
}

li {
    margin-bottom: 10px;
    padding: 5px;
    background-color: #afe5e065;
}
</style>