<script>
import TrashIcon from '@/components/Icons/TrashIcon.vue';

export default {
  components: {
    TrashIcon
   
  },
  data() {
    return {
        showModal: false, 
      tccs: ["Trabalho de Conclusão 1", "Trabalho de Conclusão 2", "Trabalho de Conclusão 3", "Trabalho de Conclusão 4", "Trabalho de Conclusão 5", 
      "Trabalho de Conclusão 6"]
    }
  },
  methods: {
    
  },
}
</script>

<template>
    <body>
        <main>
            <div class="titulo">
                <h1>Visualizar Minhas Bancas</h1>
            </div>
            <div class="tccs">
              <div v-for="tcc in tccs" :key="data" class="tcc" @click="showModal = true">
                <p class="tcc-text">Nome: {{ tcc }}</p>
              </div>
            </div>
            <div id="app">
                <div v-if="showModal" class="modal">
                    <div class="modal-content">
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
                      <div class="buttons">
                        <button class="btn btn-primary" id= "remove" @click="showModal = false">Sair</button>
                      </div>
                    </div>
                </div>
            </div>
        </main>
    </body>
</template>

<style scoped>

.tcc {
  border: 2px solid #989A9D;
  border-radius: 5px;
  box-sizing: border-box;
  margin-bottom: 20px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px; 
  text-align: center; 
}

.tcc:hover{
    cursor: pointer;
  }

.tcc-text {
    margin-bottom: 0;
    font-weight: bold;
    font-size: large;
}

.tccs {
    margin: 30px;
    width: 70%;
}

.modal {
  display: block;
  position: fixed;
  z-index: 1;
  padding-top: 100px;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  overflow: auto;
  background-color: rgb(0,0,0);
  background-color: rgba(0,0,0,0.4);
}

.modal-content {
  display: flex;
  align-items: justify;
  margin-bottom: 10px;
  background-color: #fefefe;
  margin: auto;
  padding: 20px;
  border: 1px solid #888;
  width: 40%;
}

.titulo-modal {
    color: black;
    font-weight: bolder;
    text-align: center;
}

.titulo-content {
    margin-bottom: 80px;
}

.buttons {
  position: absolute;
  bottom: 20px;
  right: 20px;
  display: flex;
  justify-content: flex-end;
}

.btn {
  margin: 5px; 
}
    
</style>