<template>
  <HeaderComponent></HeaderComponent>
  <Header2Component :titlePage="titlePageApp"></Header2Component>

  <div class="container">
    <router-view></router-view>
  </div>

  <FooterComponent></FooterComponent>
</template>

<script>
import HeaderComponent from '@/components/_comuns/header/Header.vue'
import FooterComponent from '@/components/_comuns/footer/Footer.vue'
import Header2Component from '@/components/_comuns/header2/Header2.vue'

export default {
  name: 'App',
  components: {
    HeaderComponent,
    FooterComponent,
    Header2Component
  },
  data: () => ({
    titlePageApp: "BEM VINDO AO STUDIO FLAVIA BEGOSSO"
  }),
  mounted() {
    this.emitter.on('titlePageEmit', (page) => {
      this.titlePageApp = page
    })
  }
}
</script>
