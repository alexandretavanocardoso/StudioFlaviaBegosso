<template>
    <div class="mg-top">
        <div class="flex">
            <WorkListComponent></WorkListComponent>
        </div>
    </div>
</template>

<script>
import WorkListComponent from '@/components/studio-components/_sub-studio-components/litsComponents/workList/WorkList.vue'

export default {
    name: 'AllWorksComponent',
    components: {
        WorkListComponent
    }
}
</script>

<style src="./AllWorks.scss" lang="scss" scoped></style>