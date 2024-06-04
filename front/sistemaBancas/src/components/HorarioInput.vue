<template>
  <input type="time" :value="horario" @input="updateHorario($event.target.value)"  step="3600"/>
</template>

<script>
export default {
  props: {
    value: String, // Valor inicial do campo (opcional)
  },
  data() {
    return {
      horario: this.value || '', // Inicializa com o valor passado ou vazio
    };
  },
  computed: {
    formattedHorario() {
      // Formata o horário para manter apenas as horas cheias
      return this.horario ? this.horario.slice(0, 2) + ':00' : '';
    }
  },
  methods: {
    updateHorario(value) {
      this.horario = value;
      this.$emit('input', value); // Emite o evento input para atualizar o valor no pai
    },
    limparValor() {
      this.horario = ''; // Limpa o valor do input
    }
  },
  watch: {
    value(newValue) {
      this.horario = newValue; // Atualiza o valor interno se a prop mudar
    }
  },
};
</script>
