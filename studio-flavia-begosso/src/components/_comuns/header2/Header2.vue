<template>
    <div class="cardPage">
        <h4>{{ titlePage }}</h4>
    </div>
</template> 

<script>
export default {
    name: 'Header2Component',
    props: {
        titlePage: {
            type: String
        }
    }
}
</script>

<style src="./Header2.scss" lang="scss" scoped>

</style>