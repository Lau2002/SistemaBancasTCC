<script setup lang="ts">

</script>

<template>
   <body>
        <main>
            <div class="titulo">
                <h1>Visualizar Minha Banca</h1>
            </div>
            <div class="banca-content">
                <div class="container-info">
                    <label class="bold-label">Título:</label><p class="texto-info">Trabalho de Conclusão 1</p>
                </div>
                <div class="container-info">
                    <label class="bold-label">Orientador:</label><p class="texto-info">Nome Orientador</p>
                </div>
                <div class="container-info">
                    <label class="bold-label">Avaliador 1:</label><p class="texto-info">Nome Avaliador 1</p>
                </div>
                <div class="container-info">
                    <label class="bold-label">Avaliador 2:</label><p class="texto-info">Nome Avaliador 2</p>
                </div>
                <div class="container-info">
                    <label class="bold-label">Avaliador 3:</label><p class="texto-info">Nome Avaliador 3</p>
                </div>
                <div class="container-info">
                    <label class="bold-label">Horário:</label><p class="texto-info">10/05 14:00 - 15:30</p>
                </div>
            </div>
        </main>
    </body>
</template>

<style scoped>

.bold-label {
    font-size: 22px;
    font-weight: bold;
}

.texto-info {
    font-size: 22px;
    padding-bottom: 8px;
    margin-bottom: 0px;
}

.container-info {
    display: flex;
    align-items: center;
    margin-bottom: 15px;
}

.container-info p {
    margin-left: 6px;
}

</style>
 