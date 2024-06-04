<script>
import PlusIcon from '@/components/Icons/PlusIcon.vue';
import MinusIcon from '@/components/Icons/MinusIcon.vue';
import HorarioInput from '@/components/HorarioInput.vue';


export default {
  components: {
    PlusIcon,
    MinusIcon,
    HorarioInput
  },
  data() {
    return {
      possoDiaTodo: true, 
      naoPossoDiaTodo: false,
      showModal: false, 
      horarios: [],
      selectedHour: '',
      datas: ["01/07/2024", "02/07/2024", "03/07/2024", "04/07/2024", "05/07/2024", 
      "08/07/2024", "09/07/2024", "10/07/2024", "11/07/2024", "12/07/2024"
      ]
    }
  },
  methods: {
    togglePossoDiaTodo() {
      this.naoPossoDiaTodo = !this.possoDiaTodo;
    },
    adicionarHorario() {
      this.horarios.push({ value: '' }); 
    },
    removerHorario(index) {
      this.horarios.splice(index, 1);
    },
    removerHorarios() {
      this.showModal = false;
      while (this.horarios.length > 0) {
        this.horarios.pop();
      }
    },
    
  },
}
</script>

<template>
    <body>
        <main>
            <div class="titulo">
                <h1>Registrar Meus Horários</h1>
            </div>
            <div class="dias">
              <div v-for="data in datas" :key="data" class="dia" @click="showModal = true">
                <p>{{ data }}</p>
              </div>
            </div>
            <div class="send-button">
              <button class="btn btn-primary" id= "send" @click="showModal = false">Enviar</button>
            </div>
            <div id="app">
                <div v-if="showModal" class="modal">
                    <div class="modal-content">
                      <div class="form-modal">
                        <div class="checkbox-content">
                          <input class="form-check-input" type="checkbox" id="checkbox" checked v-model="possoDiaTodo" @change="togglePossoDiaTodo">
                          <label class="form-check-label" for="checkbox">
                            Posso o dia Todo
                          </label>
                        </div>
                        <div class="adicionar-content" v-if="naoPossoDiaTodo">
                          <PlusIcon @click="adicionarHorario"/>
                          <label class="form-check-label" for="plus-input" >Adicionar Horário</label>
                        </div>
                        <div class="remover-content" v-if="naoPossoDiaTodo">
                          <MinusIcon @click="removerHorario()"/>
                          <label class="form-check-label" for="minus-input" >Remover Horário</label>
                        </div>
                        <div v-for="(horario, index) in horarios" :key="index" class="horarios-container" v-if="naoPossoDiaTodo">
                          <label :for="'input-horario-' + index" class="label-input-horario">Horário {{ index + 1 }}</label>
                          <div class="horario-input-container">
                            <input type="time" class="input-horario" step="3600"/>
                            <div class="space">-</div>
                            <input type="time" class="input-horario" step="3600"/>
                          </div>
                        </div>
                      </div>
                      <div class="buttons">
                        <button class="btn btn-primary" id= "save" @click="showModal = false">Salvar</button>
                        <button class="btn btn-primary" id= "cancel" @click="removerHorarios()">Cancelar</button>
                      </div>
                    </div>
                </div>
            </div>
        </main>
    </body>
    
</template>

<style scoped>

.dias {
  margin: 30px;
  display: flex;
  flex-wrap: wrap;
  width: calc(70% - 30px);
  align-items: center; 
  justify-content: center;
}

.dia {
  margin: 15px;
  border: 2px solid #989A9D;
  border-radius: 5px;
  text-align: justify;
  padding: 25px;
  transition: box-shadow 0.1s;
  box-sizing: border-box
}

.dia:hover {
  cursor: pointer;
  box-shadow: 0 0 15px rgba(152, 154, 157, 0.5);
}

.send-button {
  margin-left: 45px;
}

p {
  font-weight: bold;
  font-size: large;
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
  flex-direction: column;
  align-items:flex-start;
  margin-bottom: 10px;
  background-color: #fefefe;
  margin: auto;
  padding: 20px;
  border: 1px solid #888;
  width: 50%;
}

.form-check-label {
  padding-left: 10px;
}

.form-check-input {
  border-color: black;
  height: 20px;
  width: 20px;
}

input[type=checkbox]:checked {
    /* Estilo quando o checkbox está marcado */
    background-color: #214099;
}

.buttons {
  position: absolute;
  bottom: 20px;
  right: 20px;
  display: flex;
  justify-content: flex-end;
}

.btn {
  margin: 5px; /* Espaçamento entre os botões */
}

#cancel {
  background-color: #595C5F;
  border-color: #595C5F;
}

.horario-input-container {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}

.input-horario {
  border-radius: 4px;
}

.label-input-horario {
  padding-top: 10px;
}

.space {
  margin: 0 10px; /* Adiciona 10 pixels de margem horizontal */
}

.form-modal {
  margin-bottom: 70px;
}

</style>