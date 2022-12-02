<template>
  <HeaderComponent></HeaderComponent>

  <div class="container">
    <ContentComponent></ContentComponent>
  </div>
  
  <FooterComponent></FooterComponent>
</template>

<script>
import HeaderComponent from '@/components/_comuns/header/Header.vue'
import ContentComponent from '@/view/Content.vue'
import FooterComponent from '@/components/_comuns/footer/Footer.vue'

export default {
  name: 'App',
  components: {
    HeaderComponent,
    ContentComponent,
    FooterComponent
  }
}
</script>
