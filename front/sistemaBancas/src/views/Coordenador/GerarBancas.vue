<script>
import PlayIcon from '@/components/Icons/PlayIcon.vue';
import TrashIcon from '@/components/Icons/TrashIcon.vue';

export default {
  components: {
    PlayIcon,
    TrashIcon
   
  },
  data() {
    return {
        showAdicionarModal: false,
        showRemoverModal: false,
        showGerarModal: false, 
      bancas: ["2024/1", "2024/2"]
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
                <h1>Gerar Bancas</h1>
            </div>
            <div class="add-button">
                <button type="button" class="btn btn-primary" @click="showAdicionarModal = true">Adicionar</button>
            </div>
            <div class="bancas">
              <div v-for="banca in bancas" :key="data" class="banca">
                <p class="banca-text">{{ banca }}</p>
                <div class="icon-content">
                    <PlayIcon  @click="showGerarModal = true"/>
                    <TrashIcon  @click="showRemoverModal = true"/>
                </div>
              </div>
            </div>
            <div id="app">
                <div v-if="showRemoverModal" class="modal">
                    <div class="modal-content">
                        <div class="titulo-content">
                            <h1 class="titulo-modal">Deseja remover período?</h1>
                        </div>
                      <div class="buttons">
                        <button class="btn btn-primary" id= "remove" @click="showRemoverModal = false">Remover</button>
                        <button class="btn btn-primary" id= "cancel" @click="showRemoverModal = false">Cancelar</button>
                      </div>
                    </div>
                </div>
            </div>
            <div id="app">
                <div v-if="showGerarModal" class="modal">
                    <div class="modal-content">
                        <div class="titulo-content">
                            <h1 class="titulo-modal">Deseja gerar bancas?</h1>
                        </div>
                      <div class="buttons">
                        <button class="btn btn-primary" id= "generate" @click="showGerarModal = false">Gerar</button>
                        <button class="btn btn-primary" id= "cancel" @click="showGerarModal = false">Cancelar</button>
                      </div>
                    </div>
                </div>
            </div>
            <div id="app">
                <div v-if="showAdicionarModal" class="modal">
                    <div class="modal-content" id="adicionar">
                      <div class="form-modal">
                        <div class="form-group">
                            <label for="Nome">Título:</label>
                            <input type="text" class="form-control" id="titulo-periodo">
                        </div>
                        <div class="form-group">
                            <label for="inicio">Data Início:</label>
                            <input type="date" class="form-control" id="inicio-periodo">
                        </div>
                        <div class="form-group">
                            <label for="inicio">Data Fim:</label>
                            <input type="date" class="form-control" id="fim-periodo">
                        </div>
                       </div>
                      <div class="buttons">
                        <button class="btn btn-primary" id= "save" @click="showAdicionarModal = false">Salvar</button>
                        <button class="btn btn-primary" id= "cancel" @click="showAdicionarModal = false">Cancelar</button>
                      </div>
                    </div>
                </div>
            </div>
        </main>
    </body>
</template>

<style scoped>

.banca {
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

.banca-text {
    margin-bottom: 0;
    font-weight: bold;
    font-size: large;
}

.icon-content {
  display: flex;
  align-items: center;
}

.icon-content > * {
  margin-left: 10px; 
}

.icon-content > *:first-child {
  margin-left: 0; 
}

.bancas {
    margin: 30px;
    width: 70%;
}

.add-button {
    margin-left: 30px;
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

#adicionar {
    display: block;
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


#titulo-periodo {
    width: 100%;
}

#inicio-periodo {
    width: 26%;
}

#fim-periodo {
    width: 26%;
}

</style>