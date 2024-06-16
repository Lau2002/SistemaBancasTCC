<script>
import TrashIcon from '@/components/Icons/TrashIcon.vue';

export default {
  components: {
    TrashIcon
   
  },
  data() {
    return {
        showModal: false, 
      professores: ["Professor 1", "Professor 2", "Professor 3", "Professor 4", "Professor 5", 
      "Professor 6", "Professor 7", "Professor 8", "Professor 9", "Professor 10"
      ]
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
                <h1>Remover Professor</h1>
            </div>
            <div class="professores">
              <div v-for="professor in professores" :key="data" class="professor">
                <p class="professor-text">Nome: {{ professor }}</p>
                <div class="remover-content">
                    <TrashIcon  @click="showModal = true"/>
                </div>
              </div>
            </div>
            <div id="app">
                <div v-if="showModal" class="modal">
                    <div class="modal-content">
                        <div class="titulo-content">
                            <h1 class="titulo-modal">Deseja remover este professor?</h1>
                        </div>
                      <div class="buttons">
                        <button class="btn btn-primary" id= "remove" @click="showModal = false">Remover</button>
                        <button class="btn btn-primary" id= "cancel" @click="showModal = false">Cancelar</button>
                      </div>
                    </div>
                </div>
            </div>
        </main>
    </body>
</template>

<style scoped>

.professor {
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

.professor-text {
    margin-bottom: 0;
    font-weight: bold;
    font-size: large;
}

.remover-content {
  display: flex;
  align-items: center;
}

.professores {
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
  align-items:center;
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

#cancel {
  background-color: #595C5F;
  border-color: #595C5F;
}

    
</style>